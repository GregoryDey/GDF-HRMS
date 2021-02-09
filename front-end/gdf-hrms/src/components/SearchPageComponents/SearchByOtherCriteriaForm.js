import React from "react";
import { makeStyles } from "@material-ui/core/styles";
//import Typography from "@material-ui/core/Typography";
import CardContent from "@material-ui/core/CardContent";
import Button from "@material-ui/core/Button";
import Card from "@material-ui/core/Card";
import { TextField } from '@material-ui/core';
import SearchIcon from '@material-ui/icons/Search';
//import {useForm} from 'react-hook-form';

const useStyles = makeStyles((theme) => ({
  root: {
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    marginTop: theme.spacing(5),
    //margin: theme.spacing(5),
    "& > *": {
        //margin: theme.spacing(5),                         
    }
  },
    
  cardcontents: {        
    flex: 1,
    float: 'left',
    margin: theme.spacing(5),        
  }    
}));

export default function SearchByOtherCriteriaForm() {
  const classes = useStyles(); 

  return (
    <React.Fragment>
      <div>
        <Card>        
          <CardContent className={classes.cardcontents}>          
            <form className={classes.form}>
              <TextField name='fName' label='First Name' variant='outlined' margin='normal' />
              <br />
              <TextField name='lName' label='Last Name' variant='outlined' margin='normal' />
              <br />
              <TextField name='rank' label='Rank' variant='outlined' margin='normal' />
              <br />
              <Button type='submit' color='primary' variant='contained'>Search<SearchIcon /></Button>
            </form>
          </CardContent>
        </Card>
      </div>
    </React.Fragment>
  );
}