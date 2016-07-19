namespace Eficiti.Asaas.Core
{
    public class Error
    {
        public string Code { get; set; }
        public string Description { get; set; }
        
        public override string ToString()
        {
            return "Code: " + Code + " - Description: " + Description;
        }
    }
}
