using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigger
{
    public class Countries : ObservableCollection<Country>
    {
        public Countries()
        {
            this.Add(new Country("Ukraine", "UA"));
            this.Add(new Country("Russia", "RU"));
            this.Add(new Country("United States Of America", "USA"));
            this.Add(new Country("Azerbaijan", "AZ"));
            this.Add(new Country("United Kingdom", "UK"));
            this.Add(new Country("Turkey", "TR"));
        }
      
    }
}
