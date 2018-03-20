using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dolphin
{
    /// <summary>
    /// Interaction logic for AddMember.xaml
    /// </summary>
    public partial class AddMember : Window
    {
        public AddMember()
        {
            InitializeComponent();
        }

        public void CreateNewUser_Click(object sender, RoutedEventArgs e)
        {
            if (CRUDController.Instance.CreateMember(txtBoxAddMemberName.Text, txtBoxAddMemberAdress.Text, txtBoxAddMemberPhoneNumber.Text, BirthdayDatePicker.SelectedDate.Value))
            {
                MessageBox.Show("SUCCESS!!");
            }
            else
            {
                MessageBox.Show("FAIL!!");
            }
            
        }
    }
}
