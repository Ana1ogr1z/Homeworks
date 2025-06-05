SELECT month(date_first) AS Номер_месяца, count(*) AS Кол_коман
FROM trip.trip
WHERE DAY(date_first) = 1 
GROUP BY Номер_месяца