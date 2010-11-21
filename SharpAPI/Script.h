/*
 *  This file is a part of SharpAPI.
 *
 *  Copyright (C) 2010 Jack Wakefield
 *  
 *  SharpAPI is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  SharpAPI is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public License
 *  along with SharpAPI.  If not, see <http://www.gnu.org/licenses/>.
 */

#ifndef SCRIPT_H
#define SCRIPT_H

#include "Console.h"

#pragma managed
using namespace System;
using namespace IronPython;
using namespace IronPython::Hosting;
using namespace Microsoft::Scripting;
using namespace Microsoft::Scripting::Hosting;

public ref class Script {
public:
	bool Execute(String^ filePath);

public:
	static ScriptEngine^ mEngine;

private:
	ScriptSource^ mScript;
	ScriptScope^ mScope;
};

#endif