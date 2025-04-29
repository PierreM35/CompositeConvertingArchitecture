namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Containers
    {
        public Func<Parameter1, Parameter2, Parameter3, Container2, Container1> Container1 { get; set; }
        public Func<Parameter2, IEnumerable<Parameter3>, SomeEnum, Container2> Container2 { get; set; }

        public Containers()
        {
            InitSuppliers();
        }

        private void InitSuppliers()
        {
            Container1 = (param1, param2, param3, container2)
                => new Container1(param1, param2, param3, container2);

            Container2 = (param2, param3s, someEnum)
                => new Container2(param2, param3s, someEnum);
        }
    }
}
