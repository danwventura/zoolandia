

namespace zoolandia
{
    

    public class chelonoidisNigra : Animal 
    {
        public chelonoidisNigra(string name, string commonname) : base(name, commonname)
        {
            this.Name = name;
            this.CommonName = commonname;
        }

        public chelonoidisNigra(string name) : base(name)
        {
            this.Name = name;
            
        }

       
       


            public override string GetToothCount(int numOfTeeth)
        {
            var animalTeeth = base.GetToothCount(3);
            return numOfTeeth + " " + animalTeeth;
        }

    }
}