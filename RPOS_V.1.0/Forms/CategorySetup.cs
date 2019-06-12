using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using RPOS.BLL;
using RPOS.DLL;
using RPOS_V._1._0.Entities;
using MetroFramework;
using PagedList;

namespace RPOS_V._1._0.Forms
{
    public partial class CategorySetup : MetroForm
    {
        private int pagebNumber = 1;
        private IPagedList<CatagoryVm> list;
        private int total = 0;

        public async Task<IPagedList<CatagoryVm>> GetPagedList(int pageNumber = 1, int pageSize = 10)
        {

           
            return await Task.Factory.StartNew(() =>
            {
                 var data = _aCatagoryVmRepository.SelectSpecificColumnsList(@"SELECT [CatagoryId]
                                                                                      ,[CatagoryCode] Code
                                                                                      ,[CatagoryName] Name
                                                                                      ,[Details]
                                                                                      ,[IsActive]  Status     
                                                                                  FROM [dbo].[Catagory]");
                total = data.Count();
                return data
                    .ToPagedList(pageNumber, pageSize);
            });
            //return await Task.Factory.StartNew(() =>
            //{
            //    return _aCatagoryRepository.SelectAll()
            //        .ToPagedList(pageNumber, pageSize);
            //});

        }
        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await GetPagedList(++pagebNumber);
                dataGridViewCatagory.DataSource = list.ToList();
                btnNext.Enabled = list.HasNextPage;
                btnPrevious.Enabled = list.HasPreviousPage;
                lblPaging.Text = string.Format("Page {0} of {1} || Total: {2}", pagebNumber, list.PageCount, total);
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await GetPagedList(--pagebNumber);
                dataGridViewCatagory.DataSource = list.ToList();
                btnNext.Enabled = list.HasNextPage;
                btnPrevious.Enabled = list.HasPreviousPage;
                lblPaging.Text = string.Format("Page {0} of {1} || Total: {2}", pagebNumber, list.PageCount, total);
            }
        }
        //CatagoryVm
        private IGenericRepository<CatagoryVm> _aCatagoryVmRepository;
        IGenericRepository<RPOS.DLL.Catagory> _aCatagoryRepository;
        private RposEntities _entities;
        int CatagoryId = 0;
        public CategorySetup()
        {
            InitializeComponent();
            _aCatagoryVmRepository = new GenericRepository<CatagoryVm>();
            _entities = new RposEntities();
            _aCatagoryRepository = new GenericRepository<RPOS.DLL.Catagory>();
        }

        private async void LoadData()
        {

            //            var data = _aCatagoryVmRepository.SelectSpecificColumnsList(@"SELECT [CatagoryId]
            //                                                                          ,[CatagoryCode] Code
            //                                                                          ,[CatagoryName] Name
            //                                                                          ,[Details]
            //                                                                          ,[IsActive]  Status     
            //                                                                      FROM [dbo].[Catagory]");
            //            dataGridViewCatagory.DataSource = data;

            list = await GetPagedList();
            dataGridViewCatagory.DataSource = list.ToList();
            btnNext.Enabled = list.HasNextPage;
            btnPrevious.Enabled = list.HasPreviousPage;
            lblPaging.Text = string.Format("Page {0} of {1} || Total: {2}", pagebNumber, list.PageCount, total);

        }

        private void Catagory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewCatagory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            CatagoryId = Convert.ToInt32(dataGridViewCatagory.Rows[e.RowIndex].Cells[1].Value);
            textBoxCatogoryCode.Text = dataGridViewCatagory.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxCatagoryName.Text = dataGridViewCatagory.Rows[e.RowIndex].Cells[3].Value.ToString();
            richTextBoxCatagoryDetails.Text = dataGridViewCatagory.Rows[e.RowIndex].Cells[4].Value != null ? richTextBoxCatagoryDetails.Text = dataGridViewCatagory.Rows[e.RowIndex].Cells[4].Value.ToString() : "";
            checkBoxIsActive.Checked = Convert.ToBoolean(dataGridViewCatagory.Rows[e.RowIndex].Cells[5].Value);// == "true"? false : true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxCatogoryCode.Text == "" && textBoxCatagoryName.Text == "")
            {
                MetroMessageBox.Show(this, "Sorry! Category Name and Category Code are mandatory", "RPOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Catagory aCatagory;
                if (CatagoryId == 0)//then save
                {
                    aCatagory = new Catagory
                    {
                        CatagoryCode = textBoxCatogoryCode.Text,
                        CatagoryName = textBoxCatagoryName.Text,
                        Details = richTextBoxCatagoryDetails.Text,
                        IsActive = checkBoxIsActive.Checked
                    };
                    _aCatagoryRepository.Insert(aCatagory);
                }
                else
                {
                    aCatagory = new Catagory
                    {
                        CatagoryId = this.CatagoryId,
                        CatagoryCode = textBoxCatogoryCode.Text,
                        CatagoryName = textBoxCatagoryName.Text,
                        Details = richTextBoxCatagoryDetails.Text,
                        IsActive = checkBoxIsActive.Checked
                    };
                    _aCatagoryRepository.Update(aCatagory);
                }
                _aCatagoryRepository.Save();
                pagebNumber = 1;
                LoadData();

                MetroMessageBox.Show(this, "Category" + (CatagoryId == 0 ? " Saved " : " Updated ") + "Successfully!", "RPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        private void ClearAll()
        {
            CatagoryId = 0;
            textBoxCatogoryCode.Text = "";
            textBoxCatagoryName.Text = "";
            richTextBoxCatagoryDetails.Text = "";
            checkBoxIsActive.Checked = true;

        }





    }
}
