import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import "./AddStudent.css";

const AddStudent = () => {
  const [student, setStudent] = useState({
    firstName: "",
    lastName: "",
    index: "",
    faculty: "",
  });

  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();
    navigate(`/student/success/${student.index}`);
  };

  const handleChange = (e) => {
    setStudent((prevStudent) => {
      return { ...prevStudent, [e.target.name]: e.target.value };
    });
  };

  return (
    <div className="form-container">
      <h1>Add Student</h1>
      <form onSubmit={handleSubmit}>
        <div className="form-group">
          <label>First name:</label>
          <input
            type="text"
            name="firstName"
            value={student.firstName}
            onChange={handleChange}
            required
            maxLength={30}
          />
        </div>
        <div className="form-group">
          <label>Last name:</label>
          <input
            type="text"
            name="lastName"
            value={student.lastName}
            onChange={handleChange}
            required
            maxLength={30}
          />
        </div>
        <div className="form-group">
          <label>Index:</label>
          <input
            type="text"
            name="index"
            value={student.index}
            onChange={handleChange}
            required
          />
        </div>
        <div className="form-group">
          <label>Faculty:</label>
          <input
            type="text"
            name="faculty"
            value={student.faculty}
            onChange={handleChange}
            required
          />
        </div>
        <div className="form-group">
          <button type="submit">Submit</button>
        </div>
      </form>
    </div>
  );
};

export default AddStudent;
