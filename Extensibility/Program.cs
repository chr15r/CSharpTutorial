using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{

    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\chris\Documents\CSharpTutorial\ExtensibilityOutput\Log.txt"));
            dbMigrator.Migrate();
        }
    }
}
