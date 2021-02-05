import React, { useEffect, useState } from "react";
import Axios from 'axios'; // remember to npm install Axios
import { AddBoxOutlined } from "@material-ui/icons";
//import { useState } from 'react';
//import { useEffect } from 'react';

function Api() { 

    const [employee, setEmployee] = useState("")

    //const getJoke = () => {
     //   Axios.get("https://official-joke-api.appspot.com/random_joke").then((response) => {
            //console.log(response);
     //       setJoke(response.data.setup + "..." + response.data.punchline);
     //   })
   // }
    

   //calling endpoints 
    const getEmployeeByRegNumber = (RNumber) => {
        Axios.get("https://localhost:44353/api/EmployeeInfo/regnumber/" + RNumber).then((response) => {
            //console.log(response);
            setEmployee(response.data.Title + "..." + response.data.Fname);
            // which ever field you need it will be response.data.fieldName
        })
    }

    const getEmployeeByFirstName = (Fname) => {
        Axios.get("https://localhost:44353/api/EmployeeInfo/fname/" + Fname).then((response) => {
            //console.log(response);
            setEmployee(response.data.Title + "..." + response.data.Fname);
        })
    }



return (
    
<div>Hello api area <button onClick={() => getEmployeeByRegNumber(12345)}>Get employee by regNumber</button>

{employee }
</div>

);
  }

  export default Api;