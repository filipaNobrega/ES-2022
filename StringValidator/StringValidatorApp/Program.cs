using StringValidatorLibrary;

const string s1 = "patato";
const string s2 = "oo";
const string s3 = "xzy";

IValidator validator = new Or(new And(new LengthGreaterThan(5), new LengthLesserThan(8)), new LengthEqualTo(2));
bool b1 = validator.IsValid(s1);
bool b2 = validator.IsValid(s2);
bool b3 = validator.IsValid(s3);

Console.WriteLine($"'{s1}' IsValid returned {b1}");
Console.WriteLine($"'{s2}' IsValid returned {b2}");
Console.WriteLine($"'{s3}' IsValid returned {b3}");
