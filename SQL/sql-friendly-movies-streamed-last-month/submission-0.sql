-- Write your query below
select distinct c.title
from tv_program tp
Join content c On tp.content_id = c.content_id
where c.kids_content = 'Y' 
and c.content_type = 'Movies' 
and Extract(Year from tp.Program_date::date) = 2020 
and Extract(Month from tp.Program_date::date) = 6
