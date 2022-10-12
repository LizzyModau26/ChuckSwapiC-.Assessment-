import React from 'react';
import { Col } from 'react-bootstrap';
import { NavLink } from "react-router-dom";
import "../../assets/css/Navigation.css";

const Navigation = (props) => {
    return (
        <Col md={12} >
            <div className="nav" >
                <input type="checkbox" id="nav-check" />
                <div className="nav-header">
                    <div className="nav-title">
                        ChuckSwapiC#
                    </div>
                </div>
                <div className="nav-btn">
                    <label htmlFor="nav-check">
                        <span></span>
                        <span></span>
                        <span></span>
                    </label>
                </div>

                <div className="nav-links">
                    <NavLink exact to="/">Home</NavLink>
                    <NavLink to="/chuck">Chuck Jokes</NavLink>
                    <NavLink to="/swapi">Star Wars</NavLink>

                </div>
            </div>
        </Col>

    )
}

export default Navigation;

