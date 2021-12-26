using Otel.Business.Abstract;
using System;
using System.Windows.Forms;

namespace Otel.Presentation
{
    public partial class frmCustomerList : Form
    {
        private readonly ICustomerService _customerService;
        public Action act;
        public frmCustomerList(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
            act = LoadData;
            Program._act = act;
        }
        public void LoadData()
        {
            dataGridView1.DataSource = _customerService.List();

        }

    }
}
