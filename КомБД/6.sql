SELECT _name, datediff(date_last, date_first) AS Длительность_Дней
FROM trip.trip
ORDER BY Длительность_Дней ASC
LIMIT 2