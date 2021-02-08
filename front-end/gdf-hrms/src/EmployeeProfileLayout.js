import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Grid from '@material-ui/core/Grid';
import TextField from '@material-ui/core/TextField';
import SimpleSelect from './SimpleSelect';
import PersonalInformationForm from './PersonalInformationForm';
import AddressForm from './AddressForm';
import ContactForm from './ContactForm';
import OfficialInformationForm from './OfficialInformationForm';


const useStyles = makeStyles((theme) => ({
  root: {
    '& .MuiTextField-root': {
        margin: theme.spacing(1),
        width: '25ch',
        flexGrow: 1,
    }, 
  },
  
  paper: {
    padding: theme.spacing(1),
    textAlign: 'center',
    color: theme.palette.text.secondary,
  },
}));

export default function EmployeeProfileLayout() {
  const classes = useStyles();
  const SexOption = ["Male","Female"];
  function FormRow() {
    return (
      <React.Fragment>
        <div>
            <Grid item xs={6}>
            <PersonalInformationForm></PersonalInformationForm>
            </Grid>
            <Grid item xs={6}>
            <AddressForm></AddressForm>
            </Grid>
        </div>
        <div>
            <Grid item xs={6}>
            <ContactForm></ContactForm>
            </Grid >
            <Grid item xs={6}>
            <OfficialInformationForm></OfficialInformationForm>
            </Grid >
        </div>    
    
      </React.Fragment>
      
    );
  }

  return (
    <div className={classes.root}>
      <Grid container spacing={1}>
      <h4>Employee Profile Page</h4>
        <Grid container item xs={12} spacing={3}>
          <FormRow />
        </Grid>
      </Grid>
    </div>
  );
}
