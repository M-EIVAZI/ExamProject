select 
	s.Name,
	eg.GroupName,
	e.Title ,
	sum(case when sa.AnsweredAt<=DATEADD(MINUTE,e.DurationInMinutes,es.FinishedAt) then 1 else 0 end),
	SUM(CASE WHEN sa.AnsweredAt > DATEADD(MINUTE, E.DurationInMinutes, es.FinishedAt) THEN 1 ELSE 0 END)

	from examStudents as es
	inner join studentsAsnwers as sa on es.Id=sa.ExamStudentId
	inner join exams as e on es.ExamId=e.Id
	inner join students as s on es.StudentId=s.Id
	inner join examGroups as eg on eg.Id=s.GroupId
	group by s.Name,eg.GroupName,e.Title
	having
	sum(case when sa.AnsweredAt<=DATEADD(MINUTE,e.DurationInMinutes,es.FinishedAt) then 1 else 0 end)=
    SUM(CASE WHEN sa.AnsweredAt > DATEADD(MINUTE, E.DurationInMinutes, es.FinishedAt) THEN 1 ELSE 0 END);
