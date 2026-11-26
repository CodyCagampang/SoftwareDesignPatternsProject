using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Presentation
{
    public abstract class DashboardFactory
    {
        public abstract Form CreateForm();

    }

    public class ClientDashboardFactory : DashboardFactory
    {
        public override Form CreateForm()
        {
            return new frmUserDashboard();
        }
    }

    public class BookAKennelFactory : DashboardFactory
    {
        public override Form CreateForm()
        {
            return new frmBookAKennel();
        }
    }

    public class UpdateAccountFactory : DashboardFactory
    { public override Form CreateForm()
        {
            return new frmUpdateAccount();
        }

    } 
}
