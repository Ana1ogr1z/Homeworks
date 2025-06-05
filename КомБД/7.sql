SELECT *
FROM trip.trip
WHERE MONTH(date_first) = month(date_last)