import React from 'react'
import { FiCheckCircle } from 'react-icons/fi';

export const Sucess = (message) => {
  return (
    <div className="overlay">
      <div className={`icon-area red-icon`}>
        <FiCheckCircle />
      </div>
      <div className="text-area">
        <div>{message}</div>
      </div>
    </div>
  );
}

export default Sucess;