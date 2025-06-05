select * from trip
where month(date_first) = month(date_last) and year(date_first) = year(date_last)