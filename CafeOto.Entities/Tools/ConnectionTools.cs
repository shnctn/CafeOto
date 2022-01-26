using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOto.Entities.Migrations;
using CafeOto.Entities.Models;

namespace CafeOto.Entities.Tools
{
    public class ConnectionTools
    {
        public static void baglantiControl()
        {
            using (var context =new CafeContext())
            {
                if (context.Database.Exists())
                {
                    MessageBox.Show("Veritabanınız oluşturulacak.Daha sonra Ayrı  bir forma yönlenddirileeksiniz.");

                    context.Database.CreateIfNotExists();// yeni boş db oluşturuyor

                }
                else
                {
                    MessageBox.Show("Veritabanınız zaten bulunmakta.");
                }
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<CafeContext,Configuration>());// migration  bşlangıçta çalıştırma

            }
        }
    }
}
