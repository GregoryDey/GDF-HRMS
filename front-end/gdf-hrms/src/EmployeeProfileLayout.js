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
import Button from '@material-ui/core/Button';


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
  
   careerButton: {
     marginLeft: '20px,'
   }

}));



export default function EmployeeProfileLayout() {
  const classes = useStyles();
  const SexOption = ["Male","Female"];
  function FormRow() {
    return (
        <div>
          < Grid container spacing={3}>

            <Grid item xs={12}>
               <PersonalInformationForm></PersonalInformationForm>
            </Grid>

            <Grid item xs={12}>
            <AddressForm></AddressForm>
            </Grid>

            <Grid item xs={12}>
            <ContactForm></ContactForm>
            </Grid >

            <Grid item xs={12}>
            <OfficialInformationForm></OfficialInformationForm>
            </Grid >

          </Grid>
           
      </div>
      
    );
  }

  return (
    <div className={classes.root}>
      <Grid container spacing={1} >
        <Grid xs={6}>
         <h1>Employee Profile Page</h1>
        </Grid>
        <Grid xs={6}>
          <h1>
            <Button variant="outlined" color="primary"  href="#outlined-buttons">
               View Career History
            </Button>
          </h1>

        </Grid>
        <Grid container item xs={12} spacing={3}>
          <FormRow />
        </Grid>
      </Grid>
    </div>
  );
}
