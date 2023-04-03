using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ForUnitCaseWPF.Components.Model;

namespace ForUnitCaseWPF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ApishkaEntities DB = new ApishkaEntities();

        public static User LoggedUser;
        
    }
}
