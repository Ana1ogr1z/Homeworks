select * ,
datediff(date_last, date_first) as длительность_командировки from trip
order by длительность_командировки;