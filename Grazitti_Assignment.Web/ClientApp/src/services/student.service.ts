
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Student } from "src/models/student";

@Injectable()
export class StudentService {
  private url: string = "student";
  constructor(private httpService: HttpClient) {}

  public getAll(): Observable<Student[]> {
    return this.httpService.get<Student[]>(this.url);
  }
  public get(id: number): Observable<Student> {
    return this.httpService.get<Student>(this.url + "?id=" + id);
  }

  public delete(id: number): Observable<any> {
    return this.httpService.delete<any>(this.url + "?id=" + id);
  }

  public add(item: Student): Observable<any> {
    return this.httpService.post<any>(this.url, item);
  }
  public update(item: Student): Observable<any> {
    return this.httpService.patch<any>(this.url, item);
  }
}
