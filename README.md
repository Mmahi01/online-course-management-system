# online-course-management-system
Role-based online course management system using C# and SQL Server.

Certainly! Here's a polished, detailed description based on your content that you can put into your README file or GitHub project description section:

---

# Online Course Management System (OCMS)

## Introduction

The **Online Course Management System (OCMS)** is a comprehensive desktop application developed to streamline and automate the management of courses, users, and academic content in educational institutions. Designed for students, instructors, and administrators, the system provides a centralized platform that reduces manual paperwork and enhances operational efficiency in academic environments.

## Objective

The primary goal of OCMS is to simplify the processes of course enrollment, content delivery, and academic management. It empowers:

* **Admins** to efficiently manage users, courses, and enrollments.
* **Instructors** to easily upload and maintain course materials.
* **Students** to seamlessly enroll in courses and access learning content.

By integrating these capabilities, OCMS aims to foster an effective and user-friendly academic management experience.

## Scope

OCMS supports three main types of users, each with specific roles and functionalities:

1. **Admin**

   * Manages user accounts (students, instructors).
   * Oversees course creation, modification, and deletion.
   * Manages student enrollments and system data integrity.

2. **Instructor**

   * Uploads and manages course content such as lectures, documents, and resources.
   * Organizes content per course for easy student access.

3. **Student**

   * Enrolls in available courses (up to a maximum of 5).
   * Views and interacts with course content provided by instructors.

## Features

* **User Authentication:** Secure login and signup system with role-based access control.
* **Course Management:** Full CRUD (Create, Read, Update, Delete) operations for courses, including searching capabilities.
* **Enrollment Management:** Students can enroll in courses with a limit of 5 courses to ensure balanced learning loads.
* **Content Upload:** Instructors can upload various types of educational content tied to their courses.
* **Content Access:** Students can view uploaded materials and open resources directly in their web browsers.

## Tools and Technologies Used

* **Programming Language:** C#
* **Database:** Microsoft SQL Server
* **Integrated Development Environment (IDE):** Visual Studio
* **Development Approach:** Object-Oriented Programming (OOP), leveraging principles such as:

  * **Encapsulation:** Grouping related data and methods within classes.
  * **Inheritance:** Sharing common features among different user roles (Admin, Instructor, Student).
  * **Abstraction:** Simplifying database interactions through well-defined interfaces.
  * **Polymorphism:** Using method overloading for efficient form and event handling.

## User Stories

* **Admin:** “I want to manage all users and ensure course data is accurate and up-to-date.”
* **Instructor:** “I want to upload and manage my course materials easily without hassle.”
* **Student:** “I want to enroll in courses quickly and access all my learning materials from anywhere.”

## System Design Diagrams

### Entity-Relationship (ER) Diagram

**Entities:**

* **User:** Attributes include UserID, Name, Email, Password, Role.
* **Course:** Includes CourseID, Title, Description, InstructorID, Time, Capacity.
* **Enrollment:** Maps EnrollmentID, StudentID, CourseID to represent many-to-many student-course relationships.
* **CourseContent:** Includes ContentID, CourseID, ContentTitle, Content (URL or file reference), and UploadDate.

**Relationships:**

* One Instructor teaches many Courses.
* One Student can enroll in many Courses through the Enrollment entity.
* One Course can have multiple CourseContents.

### Use Case Diagram

* Actors: Admin, Instructor, Student.
* Use Cases: Login, Add/Edit/Delete Course, Enroll in Course, Upload Content, View Content, etc.

### Activity Diagram

* **Student Flow:** Login → Select Course → View Course Content.
* **Instructor Flow:** Login → Select Course → Upload/Edit Course Content.

### Sequence Diagram

* **Student Content Access:** Student → CourseContentForm → Controller → Model → Database.
* **Instructor Content Upload:** Instructor → CourseContentForm → Controller → Model → Database.


