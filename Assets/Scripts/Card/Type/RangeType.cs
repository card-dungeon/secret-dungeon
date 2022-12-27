public enum RangeType
{
    NONE = 0b_0000_0000,
    SELF = 0b_0000_0001,
    ENEMY = 0b_0000_0010,
    ALLY = 0b_0000_0100,
    ONE = 0b_0000_1000,
    FRONT = 0b_0001_0000,
    BACK = 0b_0010_0000,
    ALL = 0b_0100_0000,
}
