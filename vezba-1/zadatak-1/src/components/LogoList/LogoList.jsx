import React from "react";
import LogoItem from "../LogoItem/LogoItem";
import "./LogoList.css";

const LogoList = (props) => {
  return (
    <div className="logo-list">
      {props.logos.map((logo, index) => (
        <LogoItem key={index} name={logo.name} image={logo.image} />
      ))}
    </div>
  );
};

export default LogoList;
