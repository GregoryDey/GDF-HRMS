import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Grid from '@material-ui/core/Grid';
import TextField from '@material-ui/core/TextField';
import SimpleSelect from '../SimpleSelect';




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

export default function OfficialInformationForm({employeePI}) {
  const classes = useStyles();
  const SexOption = ["Male","Female"];
  function FormRow() {
    return (
      <React.Fragment>
        <div>
            <Grid item xs={2}>
            <TextField id="RegimentalNumber" label="RegimentalNumber" variant="outlined" size="small" value={employeePI.rNumber}/>
            </Grid>
        </div>
        <div>
            <Grid item xs={2}>
                <TextField id="IdentificationNumber" label="IdentificationNumber" variant="outlined" size="small" value={employeePI.nidNumber}/>
            </Grid>
        </div>
        <div>
            <Grid item xs={2}>
            <TextField id="PassportNumber" label="PassportNumber" variant="outlined" size="small" value={employeePI.pNumber}/>
            </Grid >
        </div>
        <div>
            <Grid item xs={2}>
            <TextField id="PassportExpirationDate" label="Passport Expiration Date" variant="outlined" size="small" InputLabelProps={{ shrink: true,}} type="text" value={employeePI.pExpirationDate}/>
            </Grid >
        </div>    
        <div>
        <Grid item xs={2}>
            <TextField id="NISNumber" label="TIN Number" variant="outlined" size="small" value={employeePI.tinNumber}/>
            </Grid>
        </div>
    
      </React.Fragment>
      
    );
  }

  return (
    <div className={classes.root}>
      <Grid container spacing={1}>
      <h4>Official Information</h4>
        <Grid container item xs={12} spacing={3}>
          <FormRow />
        </Grid>
      </Grid>
    </div>
  );
}
