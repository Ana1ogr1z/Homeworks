select 
month(date_first) as номер_месяца, 
count(trip_id) as количество_командировок 
from 
trip
group by 
номер_месяца
order by 
номер_месяца;