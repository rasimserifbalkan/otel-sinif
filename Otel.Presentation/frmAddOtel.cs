using Otel.Business.Abstract;
using Otel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Otel.Presentation
{
    public partial class frmAddOtel : Form
    {
        private readonly IOtelService _otelService;
        public frmAddOtel(IOtelService otelService)
        {
            _otelService = otelService;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> errorList = new List<string>();
            if (txtName.Text.Length == 0)
            {
                errorList.Add("İsim Giriniz");
            }
            if (txtPhone.Text.Length == 0)
            {
                errorList.Add("Telefon Giriniz.");
            }
            if (txtAddress.TextLength == 0)
            {
                errorList.Add("Adres Giriniz");
            }
            if (txtAddress.TextLength > 250)
            {
                errorList.Add("Adres 250 karakterden büyük olamaz.");
            }

            if (errorList.Count == 0)
            {
                OtelModel otelModel = new OtelModel();
                otelModel.Name = txtName.Text;
                otelModel.PhoneNumber = txtPhone.Text;
                otelModel.OtelAddress = txtAddress.Text;
                _otelService.Add(otelModel);

            }
        }
    }
}
