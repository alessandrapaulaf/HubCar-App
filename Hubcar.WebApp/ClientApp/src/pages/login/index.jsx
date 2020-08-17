import React, { useEffect, useState } from 'react';
import './styles.css';
import FormLogin from './components/login';
import Register from './components/register';
import { Card } from 'reactstrap';

const Login = () => {
  const [ register, setRegister] = useState(0);

  useEffect(() =>{
    
  }, []);

  function handleChangeRegister(){
    setRegister(register + 1);
  }

  return(
    <div id="page-home">
      <div className="login">
        <Card className="card">
          {
            register % 2 == 0?
            <FormLogin/>
            :
            <Register/>
          }
          <a style={{marginTop: 15}} className="link" onClick={handleChangeRegister}>
            {register % 2 != 0? "Login" : "Cadastre-se"}
          </a>
        </Card>
      </div>
    </div>
  );
} 

export default Login;
