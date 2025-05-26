namespace DigitalMessageService.Coders
{
    public static class CoderGetter
    {
        public static IntCoder ForParameter1() => new(4);
        public static DblCoder ForParameter2() => new(6);
        public static DblExpCoder ForParameter3() => new(4, 3);
    }
}
