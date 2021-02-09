import ResponsiveDrawer from './Layout'
import Api from './Api'
import React from "react";
import { Route } from 'react-router';
import { BrowserRouter } from 'react-router-dom';
import SearchPage from './searchpage';
import EmployeeProfileLayout from './EmployeeProfileLayout';
import CareerHistoryLayout from './CareerHistoryLayout';

const App = () => {
  return (
    <div className="App">
      <BrowserRouter>
        <ResponsiveDrawer>
          <Route path="/" exact component={EmployeeProfileLayout} />
          <Route path="/employeehistory" component={CareerHistoryLayout} />
          {/* <EmployeeProfileLayout></EmployeeProfileLayout> */}
          {/* <CareerHistoryLayout></CareerHistoryLayout> */}
      </ResponsiveDrawer>
      </BrowserRouter>
    </div>
  );
}

export default App;
