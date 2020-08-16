import React, { useEffect, useState } from 'react';
import './styles.css';
import FormLogin from './components/login';
import Register from './components/register';
import { Card } from 'reactstrap';

const Login = () => {
  const [ register, setRegister] = useState(false);

  useEffect(() =>{
    
  }, []);

  return(
    <div id="page-home">
      <div className="login">
        <Card className="card">
          {
            !register ?
            <FormLogin/>
            :
            <Register/>
          }
          <a href={register ? "/register" : "/login"}>{register ? "Login" : "Cadastre-se"}</a>
        </Card>
      </div>
    </div>
  );
} 

export default Login;
