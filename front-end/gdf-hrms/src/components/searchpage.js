import React from "react";
import { makeStyles } from "@material-ui/core/styles";
import Typography from "@material-ui/core/Typography";
import CardContent from "@material-ui/core/CardContent";
import Card from '@material-ui/core/Card';
import SearchByRegimentNumberForm from './SearchPageComponents/SearchByRegimentNumberForm';
import SearchByOtherCriteriaForm from './SearchPageComponents/SearchByOtherCriteriaForm';

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
  }    
}));

export default function SearchPage() {
  const classes = useStyles();  

  return (
    <div className={classes.root}>
      <Card>
        <CardContent className={classes.cardcontents}>
          <Typography variant='h5' align='center' gutterBottom>Search by Regiment Number</Typography>        
          <SearchByRegimentNumberForm> </SearchByRegimentNumberForm>
        </CardContent>
      
        <CardContent className={classes.cardcontents}>
          <Typography variant='h5' align='center' gutterBottom>Search by Other Criteria</Typography>
          <SearchByOtherCriteriaForm> </SearchByOtherCriteriaForm>
        </CardContent>
      </Card>      
    </div>
  );
}