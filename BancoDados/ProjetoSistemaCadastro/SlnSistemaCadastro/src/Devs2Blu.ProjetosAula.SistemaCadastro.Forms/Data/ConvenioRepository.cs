using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class ConvenioRepository
    {

        public MySqlDataReader FetchAll()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            /*DataSet dataSet = new DataSet();*/
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONVENIO,conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                return mySqlDataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #region SQLS
        private const String SQL_SELECT_CONVENIO = "SELECT * FROM convenio";
        #endregion
    }
}
