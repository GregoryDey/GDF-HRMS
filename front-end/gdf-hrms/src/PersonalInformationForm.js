import React, { useState } from 'react';
import { makeStyles } from '@material-ui/core/styles';
import TextField from '@material-ui/core/TextField';
import SimpleSelect from './SimpleSelect';

const useStyles = makeStyles((theme) => ({
  root: {
    '& .MuiTextField-root': {
      margin: theme.spacing(1),
      width: '25ch',
    },
  },
}));


export default function PersonalInformationForm() {
  const classes = useStyles();
  
  return (
    
    <form className={classes.root} noValidate autoComplete="off">
      <div>
        <TextField id="FirstName" label="First Name" variant="outlined" size="small" />
        <TextField id="dateOfBirth" label="Date of Birth" variant="outlined" InputLabelProps={{ shrink: true,}} size="small" type="date" />
        <div><SimpleSelect></SimpleSelect></div>
      </div>
      <div>
        <TextField id="LastName" label="Last Name" variant="outlined" size="small" />
        </div>
      <div>
        <TextField id="MiddleNameOne" label="Middle Name" variant="outlined" size="small" />
        </div>
      <div>
        <TextField id="MiddleNameTwo" label="Middle Name" variant="outlined" size="small" />
        </div>
      <div>
        <TextField id="MiddleNameThree" label="Middle Name" variant="outlined" size="small" />
        </div>
    </form>
  );
}