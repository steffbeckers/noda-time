using NodaTime;

DateTime dateTime = new DateTime(2023, 10, 26, 22, 0, 0, DateTimeKind.Utc);
Console.WriteLine("dateTime:");
Console.WriteLine(dateTime);
Console.WriteLine("dateTime L:");
Console.WriteLine(dateTime.ToLocalTime());
Console.WriteLine("dateTime.AddDays(30):");
Console.WriteLine(dateTime.AddDays(30));
Console.WriteLine("dateTime.AddDays(30) L:");
Console.WriteLine(dateTime.AddDays(30).ToLocalTime());

Console.WriteLine();

LocalDateTime localDateTime = LocalDateTime.FromDateTime(new DateTime(2023, 10, 27));
Console.WriteLine("localDateTime:");
Console.WriteLine(localDateTime);
Console.WriteLine("localDateTime.PlusDays(30):");
Console.WriteLine(localDateTime.PlusDays(30));

Console.WriteLine();

DateTimeZone dateTimeZone = DateTimeZoneProviders.Tzdb["Europe/Brussels"];
ZonedDateTime zonedDateTime = localDateTime.InZoneStrictly(dateTimeZone);
Console.WriteLine("zonedDateTime:");
Console.WriteLine(zonedDateTime);
Console.WriteLine("zonedDateTime.ToInstant():");
Console.WriteLine(zonedDateTime.ToInstant());
Console.WriteLine("zonedDateTime.IsDaylightSavingTime():");
Console.WriteLine(zonedDateTime.IsDaylightSavingTime());
Console.WriteLine("zonedDateTime.Plus(Duration.FromDays(30)):");
Console.WriteLine(zonedDateTime.Plus(Duration.FromDays(30)));
Console.WriteLine("zonedDateTime.Plus(Duration.FromDays(30)).IsDaylightSavingTime():");
Console.WriteLine(zonedDateTime.Plus(Duration.FromDays(30)).IsDaylightSavingTime());
Console.WriteLine("zonedDateTime.Plus(Duration.FromDays(30)).ToDateTimeUtc():");
Console.WriteLine(zonedDateTime.Plus(Duration.FromDays(30)).ToDateTimeUtc());
