[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/P_lvW_xH)
# Task 04: ASP.NET - Razor Pages

<img alt="points bar" align="right" height="36" src="../../blob/badges/.github/badges/points-bar.svg" />

![GitHub Classroom Workflow](../../workflows/GitHub%20Classroom%20Workflow/badge.svg)

***

## Student info

> Write your name, your estimation of how many points you will get, and an estimate of how long it took to make the answer

- Student name: 
- Estimated points: 
- Estimated time (hours): 

***

## Purpose of this task

The purposes of this task are:

- to learn basics of ASP.NET Razor Pages style web application
- to learn routing to pages
- to learn to handle GET and POST requests in Razor Pages app

## Material for the task

> **Following material will help with the task.**

It is recommended that you will check the material before start coding.

1. [Introduction to Razor Pages in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-6.0)
2. [Tutorial: Create a Razor Pages web app with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-6.0)

## The Task

Create a Phone database web application with ASP.NET Razor Pages. The app has basic CRUD (Create, Read, Update and Delete) operations on data. The app uses SQLite database as a persistent storage for phone data. The model classes, DbContext and SQLite configuration is given. The task is to create the user interface and code to handle user actions.

### Evaluation points

1. Index page (/) that renders text: `Welcome to the Modern Phone database in Razor Pages 2024 edition` in H1 tag and top 4 latest added or modified phones with all info (all fields' data) in a HTML table element. Each property is in its own table cell. The table must contain a header row with the property names on columns. The `Id` property is in the first column.
2. A list page (/phones) that lists all the phones from the database in alphabetical order by Make and then by Model fields. Use `ul` element with css class `phones` to list the phones. Each `li` element in the `ul` element contains the phone's make and model as the element's text content and links (`a` element) to edit and delete pages for the current phone. The list page has also a link button (`a` element styled as a button using bootstrap styles) to add page (/phones/add).
3. Add page (/phones/add) that contains fields for all Phone class' properties except the fields that are populated by the app (the fields are marked with code comments on the class declaration). Use `Phone` class as the bind property type and use `Phone` as the property's name. Model the fields so that POSTing the form will add a new phone information to the database. The page must not contain any other fields for data input. Use `button` element as the submit button. When the POST is successful the app redirects to /phones page to list all the phones including the newly added phone.

    > **Note about fields containing dates and times!**  Using a `DateTime` property to create an input element there is a thing concerning the automated tests. If the app pre populates the datetime field with a value (which is a good thing to guide the user), it will prevent the tests from passing. There are two ways to address this issue.
    > 
    > 1. Do not pre populate the field
    > 2. If you want to pre populate, then manually add `step` attribute with value `Any` to the input element.
    > 
    > `<input type="..." ... step="Any" />`

4. Edit page (/phones/edit/[id]) that allows editing of the phone's data. Value for the [id] part of the url selects the phone by it's Id property to be edited. Edit page renders input fields for all of the `Phone` class' properties and marks input fields for properties Id, Created and Modified to readonly so user gets the indication that these fields should not be modified by the user. The page must not contain any other fields for data input. Use `Phone` class as the bind property type and use `Phone` as the property's name. Use `button` element as the submit button. POSTing the form makes the changes to the selected phone object and persists them to the database. When the POST is successful the app redirects to /phones page to list all the phones including the changed phone.
5. Delete page (/phones/delete/[id]) that shows all of the selected phone's details and a button (submit type) where user can click to confirm delete. POSTing the confirmation form deletes the selected phone from the database. When the POST is successful the app redirects to /phones page to list all the remaining phones.

> **Note!** Read the task description and the evaluation points to get the task's specification (what is required to make the app complete).

## Task evaluation

Evaluation points for the task are described above. An evaluation point either works or does not work there is no "it kind of works" step in between. Be sure to test your work. All working evaluation points are added to the task total and will count toward the course total. The task is worth five (5) points. Each evaluation point is checked individually and each will provide one (1) point so there are five checkpoints. Checkpoints are designed so that they may require additional code, that is not checked or tested, to function correctly.

## DevOps

There is a DevOps pipeline added to this task. The pipeline will build the solution and run automated tests on it. The pipeline triggers when a commit is pushed to GitHub on the main branch. So remember to `git commit` and `git push` when you are ready with the task. The automation uses GitHub Actions and some task runners. The automation is in the folder named .github.

> **DO NOT modify the contents of .github or tests folders.**
