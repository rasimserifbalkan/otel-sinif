using Otel.Business.Abstract;//----
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Otel.Presentation
{
    public partial class frmReservationAdd : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IOtelService _otelService;
        public frmReservationAdd(ICustomerService customerService, IOtelService otelService)
        {
            InitializeComponent();
            _customerService = customerService;
            _otelService = otelService;
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            Action act = () => {

                var list = _customerService.List(txtCustomerName.Text.Trim()); // trim son baş boşluk alır.
                dataCustomerList.DataSource = list;
            };
         
            dataCustomerList.BeginInvoke(act);
        }
    }
}
