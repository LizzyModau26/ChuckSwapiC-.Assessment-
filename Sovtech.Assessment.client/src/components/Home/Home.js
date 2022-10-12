import React from 'react';
import '../../assets/css/Home.css';



const style = {

    margin: "0",
    padding: "5rem",
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
    color: "white"

}

const home = (props) => {
    return (
        <div style={style}>

            <div style={{ "fontSize": "90px" }} className="font-link">
                Ready For Some Laughs And Intergalactic Fun!!
            </div>

            <br />
        </div>
    )
}

export default home;