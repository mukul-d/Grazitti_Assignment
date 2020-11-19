import { Component, OnInit } from "@angular/core";

import { Student } from "src/models/student";
import { StudentService } from "src/services/student.service";
@Component({
  selector: "app-student",
  templateUrl: "./student.component.html",
  styleUrls: ["./student.component.css"],
})
export class StudentComponent implements OnInit {
  constructor(private studentService: StudentService) {}

  students: Student[];
  student: Student;
  displayForm: boolean = false;
  isAdding: boolean = false;

  displayedColumns: string[] = [
    "id",
    "firstName",
    "lastName",
    "class",
    "section",
    "actions"
  ];

  ngOnInit() {
    this.populateStudents();
  }

  populateStudents() {
    this.studentService.getAll().subscribe((data) => (this.students = data));
  }

  getStudent(id: number) {
    return this.studentService
      .get(id)
      .subscribe((data) => (this.student = data));
  }

  deleteStudent(student: Student) {
    if (
      confirm(
        `Are you sure you want to delete ${student.firstName} ${student.lastName}`
      )
    ) {
      this.studentService
        .delete(student.id)
        .subscribe(() => this.populateStudents());
    }
  }

  updateStudent(student: Student) {
    this.studentService.update(student).subscribe(() => {
      this.populateStudents();
      this.cancelAddEdit();
    });
  }
  addStudent(student: Student) {
    this.studentService.add(student).subscribe(() => {
      this.populateStudents();
      this.cancelAddEdit();
    });
  }
  addNewStudent() {
    this.student = {};
    this.displayForm = true;
    this.isAdding = true;
  }
  edit(student: Student) {
    this.student = { ...student };
    this.displayForm = true;
    this.isAdding = false;
  }

  cancelAddEdit() {
    this.student = undefined;
    this.displayForm = false;
  }
}
