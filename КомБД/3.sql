SELECT city, COUNT(*) AS Кол_поездок
FROM trip.trip
group by city