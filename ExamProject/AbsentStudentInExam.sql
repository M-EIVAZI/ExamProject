select 
	*
	from 
	students as s
	inner join examStudents as es on s.Id=es.StudentId
	inner join examGroups as eg on s.GroupId=eg.Id
	where
	eg.Id=1
	and s.Id not in(
	select es2.Studentid
	from examStudents as es2
	inner join exams as e2 on es2.ExamId=e2.Id
	where e2.GroupId=1
	);