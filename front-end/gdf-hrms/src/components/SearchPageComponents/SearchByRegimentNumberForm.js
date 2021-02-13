//import React from "react";
import { makeStyles } from "@material-ui/core/styles";
import CardContent from "@material-ui/core/CardContent";
import Button from "@material-ui/core/Button";
import Card from "@material-ui/core/Card";
import { TextField } from '@material-ui/core';
import SearchIcon from '@material-ui/icons/Search';
import { useForm } from 'react-hook-form';
//import Api from '../Api'
import React, { useState } from "react";
import Axios from 'axios'; // remember to npm install Axios

const useStyles = makeStyles((theme) => ({
  root: {
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    marginTop: theme.spacing(5),    
  },
    
  cardcontents: {        
    flex: 1,
    float: 'left',
    margin: theme.spacing(5),        
  },

  paragraphColor: {
    color: 'red'
  }
}));

export default function SearchByRegimentNumberForm() {

  const [employee, setEmployee] = useState("")
  const classes = useStyles();

  //calling endpoints 
  const getEmployeeByRegNumber = (RNumber) => {
    Axios.get("https://localhost:44353/api/EmployeeInfo/regnumber/" + RNumber).then((response) => {
        //console.log(response);
        setEmployee(response.data.title + "..." + response.data.fname);
        // which ever field you need it will be response.data.fieldName
        console.log(response.data.fname);
    })
}


  const { register, handleSubmit, errors } = useForm();
  let onSubmit = data => getEmployeeByRegNumber(data.regNum);
  //fetch('https://localhost:44353/api/EmployeeInfo/regnumber/123456').then(res => console.log(res.json() )) .then(json => {
   // this.setState ({
       //isLoaded: true,
       //items: json,
      // items.fname
       
   // })
    //console.log(res)
 //});
  //Api.getEmployeeByRegNumber(data);
  //getEmployeeByRegNumber(data)
  
  return (    
    <React.Fragment>
      <div> {employee}
        <Card>
          <CardContent className={classes.cardcontents}>          
            <form className={classes.form} align='center' onSubmit={handleSubmit(onSubmit)}>
              <TextField name='regNum' label='Regiment Number' variant='outlined' margin='normal' defaultValue={''} inputRef={register({ required: true, minLength: 6, maxLength: 6, type: "number", pattern: /^[0-9]+$/i })}/>
              {errors.regNum && errors.regNum.type === 'required' && (<p className={classes.paragraphColor}>Regiment Number is required</p>)}
              {errors.regNum && errors.regNum.type === 'minLength' && (<p className={classes.paragraphColor}>A minimum of 6 numbers required</p>)}
              {errors.regNum && errors.regNum.type === 'maxLength' && (<p className={classes.paragraphColor}>A maximum of 6 numbers required</p>)}
              {errors.regNum && errors.regNum.type === 'pattern' && (<p className={classes.paragraphColor}>Invalid regiment number</p>)}
              <br />
              <Button type='submit' color='primary' variant='contained'>Search<SearchIcon /></Button>               
            </form>
          </CardContent>        
        </Card>
      </div>
    </React.Fragment>    
  );
}

