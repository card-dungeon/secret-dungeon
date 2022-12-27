public static class StatusType
{
    public static int NONE = 0b_0000_0000_0000_0000;
    public static int HEAL = 0b_0000_0000_0000_0001;
    public static int BLEEDING = 0b_0000_0000_0000_0010;
    public static int POISON = 0b_0000_0000_0000_0100;
    public static int CURSE = 0b_0000_0000_0000_1000;
    public static int FREEZING = 0b_0000_0000_0001_0000;
    public static int BURN = 0b_0000_0000_0010_0000;
    public static int PARALYSIS = 0b_0000_0000_0100_0000;
    public static int SLEEP = 0b_0000_0000_1000_0000;
    public static int STUN = 0b_0000_0001_0000_0000;
}
