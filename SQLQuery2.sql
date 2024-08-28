alter table Employee with check add constraint fk_emp_dept foreign key(departmentid)
references department(id)

alter table Employee  check  constraint fk_emp_dept