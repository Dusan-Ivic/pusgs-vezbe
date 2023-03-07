import React from "react";
import { Link } from "react-router-dom";
import "./LogoList.css";
import { logos } from "../../data/logos";

const LogoList = () => {
  return (
    <div className="logo-list">
      {logos.map((logo, index) => (
        <Link key={index} to={`/logos/${logo.name}`}>
          {logo.name}
        </Link>
      ))}
    </div>
  );
};

export default LogoList;
