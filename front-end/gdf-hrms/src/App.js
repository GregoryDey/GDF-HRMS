import ResponsiveDrawer from './components/Layout';
import Api from './components/Api';
import React from "react";
import { Route } from 'react-router';
import { BrowserRouter } from 'react-router-dom';
import SearchPage from './components/searchpage';
import EmployeeProfileLayout from './components/EmployeeProfileLayout';
import CareerHistoryLayout from './components/CareerHistoryLayout';

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
