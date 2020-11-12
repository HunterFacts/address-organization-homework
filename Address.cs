using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressOrganization
{
    class Address
    {
        /// <summary>
        /// Улица
        /// </summary>
        public string street;

        /// <summary>
        /// Номер дома
        /// </summary>
        public int houseNumber;

        /// <summary>
        /// Корпус
        /// </summary>
        public string housing;

        /// <summary>
        /// Населенный пункт
        /// </summary>
        public string settlement;

        /// <summary>
        /// Район
        /// </summary>
        public string district;

        /// <summary>
        /// Республика, Край
        /// </summary>
        public string republic;

        /// <summary>
        /// Страна
        /// </summary>
        public string country;

        /// <summary>
        /// Индекс
        /// </summary>
        public int indexAddress;

        private string _secret;
        
        public string AddressBuild
        {
            get
            {
                return "ул. " + this.street + ", д." + this.houseNumber.ToString()
                        + ", "
                        + (this.housing != "" && this.housing != null && this.housing != "0" ? "корп." + this.housing + ", " : "")
                        + this.settlement
                        + ", "
                        + this.indexAddress.ToString();
            }
        }
        public Address()
        {}
        public Address(
            string street, 
            int houseNumber,
            string housing,
            string settlement,
            string district,
            string republic,
            string country,
            int indexAddress
            )
        {
            this.street = street;
            this.houseNumber = houseNumber;
            this.housing = housing;
            this.settlement = settlement;
            this.district = district;
            this.republic = republic;
            this.country = country;
            this.indexAddress = indexAddress;

            this._secret = this.housing != "" && this.housing != null && this.housing != "0" ? "Secret":"";
        }
    }
}
