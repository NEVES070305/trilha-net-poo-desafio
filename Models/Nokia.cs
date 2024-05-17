namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public List<string> Apps { get; set; }
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {
            Apps = new List<string>();
        }
        public override void  InstalarAplicativo(string nomeApp){
            Apps.Add(nomeApp);
        }
    }
}