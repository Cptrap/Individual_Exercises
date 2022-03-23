using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;


namespace Session_14
{
    public class OpenForm
    {
        
        
        public OpenForm()
        {

        }
        public void Open<T>() where T : Form, new()
        {
            var form = new T();
            form.Show();
        }
        
    }
}
