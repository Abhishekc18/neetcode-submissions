select 
    Least(from_id,to_id) as person1,
    Greatest(from_id,to_id) as person2,
    Count(*) as call_count,
    Sum(duration) as total_duration
from calls
group by
    Least(from_id,to_id),
    Greatest(from_id,to_id)