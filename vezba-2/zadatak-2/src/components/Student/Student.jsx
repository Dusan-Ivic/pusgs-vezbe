import React from "react";
import { useParams, Link } from "react-router-dom";

const Student = () => {
  const { index } = useParams();

  return (
    <div>
      <h1>Student with Index number "{index}" successfully added!</h1>
      <Link to="/student/new">Add new student</Link>
    </div>
  );
};

export default Student;
