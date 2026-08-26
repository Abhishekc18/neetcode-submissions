select user_id, Max(time_stamp) as last_stamp
from logins
--where YEAR(time_stamp) = 2020
where time_stamp >= '2020-01-01 00:00:00' and time_stamp <= '2020-12-31 23:59:59'
group by user_id;