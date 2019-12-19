using System.Globalization;

namespace Course_14_Interfaces.Entities
{
    class Invoice
    {
        public double BasePayment { get; set; }
        public double Tax { get; set; }

        /*  PROPRIEDADE CALCULADA */
        public double TotalPayment
        {
            get
            {
                return BasePayment + Tax;
            }
        }

        public Invoice(double basePayment, double tax)
        {
            BasePayment = basePayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasePayment.ToString("F2", CultureInfo.InvariantCulture)
                +"\nTax: "
                +Tax.ToString("F2",CultureInfo.InvariantCulture)
                +"\nTotal Payment: "
                +TotalPayment.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
