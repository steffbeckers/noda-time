using NodaTime;

DateTime dateTime = new DateTime(2023, 10, 27, 22, 0, 0, DateTimeKind.Utc);
Console.WriteLine("dateTime:\t\t\t\t\t" + dateTime);
Console.WriteLine("dateTime.AddDays(30):\t\t\t\t" + dateTime.AddDays(30));

Console.WriteLine();

LocalDateTime localDateTime = LocalDateTime.FromDateTime(dateTime);
Console.WriteLine("localDateTime:\t\t\t\t\t" + localDateTime);
Console.WriteLine("localDateTime.PlusDays(30):\t\t\t" + localDateTime.PlusDays(30));

Console.WriteLine();

DateTimeZone belgium = DateTimeZoneProviders.Tzdb["Europe/Brussels"];
ZonedDateTime zonedDateTime = localDateTime.InZoneStrictly(belgium);
Console.WriteLine("zonedDateTime:\t\t\t\t\t" + zonedDateTime);
Console.WriteLine("zonedDateTime.Plus(Duration.FromDays(30)):\t" + zonedDateTime.Plus(Duration.FromDays(30)));
